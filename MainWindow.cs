using Godot;
using System;
using System.Collections.Generic;
using System.IO.Ports;

public class MainWindow : Control
{
	private SerialPort port;
	private string[] availablePorts;
	
	private OptionButton portSelector;
	private OptionButton baudSelector;
	private Button connectButton;
	
	private TextEdit codeView;
	private OptionButton vehicleTypeSelector;
	private Button scanDTCButton;
	private Button clearDTCButton;
	
	private TextEdit terminalView;
	private LineEdit terminalInput;
	private Button terminalSendButton;
	
	private TextEdit logView;
	
	private void WriteToLog(String message) {
		System.Console.WriteLine("Log: " + message);
		logView.Text = logView.Text + message + "\n";
	}
	
	private void WriteToTerminal(String message) {
		System.Console.WriteLine("Terminal: " + message);
		terminalView.Text = terminalView.Text + message + "\n";
	}
	
	private void WriteToCodeView(String message) {
		System.Console.WriteLine("DTC View: " + message);
	}
	
	private void WriteToPort(String message) {
		port.WriteLine(message);
		WriteToTerminal("Send: " + message);
		try { 
			port.ReadLine(); // Get rid of echo from the ELM327
		} catch(Exception) {}
	}
	
	private void WaitForResponseTimeout() {
		WriteToLog("Waiting for timeout...");
		while(true) {
			try {
				String temp = port.ReadLine();
				WriteToTerminal("Recv: " + temp);
			} catch(Exception) { break; }
		}
	}
	
	private string[] WaitForFullResponse() {
		WriteToLog("Waiting for reponse...");
		List<string> response = new List<string>();
		while(true) {
			try {
				String temp = port.ReadLine();
				WriteToTerminal("Recv: " + temp);
				response.Add(temp);
			} catch(Exception) { break; }
		}
		return response.ToArray();
	}
	
	private void InitialiseInterface() {
		WriteToLog("Initialising OBD-II interface...");
		port.ReadTimeout = 250;
		port.NewLine = "\r";
		WriteToPort("atd");
		WaitForResponseTimeout();
		WriteToPort("atal");
		WaitForResponseTimeout();
		WriteToPort("ats1");
		WaitForResponseTimeout();
		WriteToPort("ath1");
		WaitForResponseTimeout();
		WriteToLog("Initialisation done.");
	}
	
	private void InitialisePort() {
		WriteToLog("Attempting to connect to OBD-II adapter...");
		string selectedPort = portSelector.GetItemText(portSelector.GetSelectedId());
		string selectedBaud = baudSelector.GetItemText(baudSelector.GetSelectedId());
		
		if(selectedBaud == "Auto") {
			WriteToLog("Auto Baudrate enabled.");
			try {
				WriteToLog("Trying 9600 baud...");
				int baudrate = 9600;
				port = new SerialPort(selectedPort, baudrate, Parity.None, 8, StopBits.One);
				port.Open();
			} catch(Exception) {
				WriteToLog("Trying 38400 baud...");
				int baudrate = 38400;
				port = new SerialPort(selectedPort, baudrate, Parity.None, 8, StopBits.One);
				port.Open();
			}
			WriteToLog("Success!");
		} else {
			WriteToLog("Auto Baudrate disabled.");
			int baudrate = int.Parse(selectedBaud);
			port = new SerialPort(selectedPort, baudrate, Parity.None, 8, StopBits.One);
			port.Open();
		}
		
		InitialiseInterface();
	}
	
	private void SendTerminalData() {
		WriteToPort(terminalInput.Text);
		WaitForResponseTimeout();
		WaitForResponseTimeout();
		terminalInput.Text = "";
	}
	
	private String ConvertDTCToString(String str)
	{
		try {
			String firstByte = str.Substring(0, 2);
			String secondByte = str.Substring(2, 2);

			int firstInt = int.Parse(firstByte, System.Globalization.NumberStyles.HexNumber);
			int secondInt = int.Parse(secondByte, System.Globalization.NumberStyles.HexNumber);

			int firstValue = (firstInt & 0b11000000) >> 6;
			int secondValue = (firstInt & 0b00110000) >> 4;
			int thirdValue = firstInt & 0b00001111;
			int fourthValue = (secondInt & 0b11110000) >> 4;
			int fifthValue = secondInt & 0b00001111;

			String troubleCode = "";
			if (firstValue == 0) troubleCode += "P";
			else if (firstValue == 1) troubleCode += "C";
			else if (firstValue == 2) troubleCode += "B";
			else if (firstValue == 3) troubleCode += "U";

			troubleCode += secondValue.ToString();
			troubleCode += thirdValue.ToString("X");
			troubleCode += fourthValue.ToString("X");
			troubleCode += fifthValue.ToString("X");

			return troubleCode;
		} catch(Exception) {
			WriteToLog("Failed to parse trouble codes! Information may be incomplete.");
			return "ERROR, see log";
		}
	}
	
	private void ClearDTCs() {
		WriteToLog("Clearing trouble codes...");
		WriteToPort("14");
		WaitForResponseTimeout();
	}
	
	private void ScanDTCs() {
		WriteToLog("Scanning for trouble codes...");
		codeView.Text = ""; 
		if(vehicleTypeSelector.Selected == 0) // Generic Scan
		{
			ReadOutTroubleCodes("03");
			ReadOutTroubleCodes("07");
			ReadOutTroubleCodes("0A");
		} else if(vehicleTypeSelector.Selected == 1) // GM '96-'08
		{
			WriteToPort("atsh6cfef1"); // Tell ALL GM modules to respond
			WaitForFullResponse();
			ReadOutGMTroubleCodes("1992FF00");
			ReadOutTroubleCodes("03");
			ReadOutTroubleCodes("07");
			ReadOutTroubleCodes("0A");
		}
	}

	private void ReadOutTroubleCodes(String command) {
		WriteToPort(command);
		string[] Codes = WaitForFullResponse();
		foreach (string Code in Codes)
		{
			if (Code.Length > 7)
			{
				string HexCode = Code.Substring(3, 2) + Code.Substring(6, 2);
				if (HexCode != "0000") WriteToCodeView(ConvertDTCToString(HexCode));
			}
		}
	}

	private void ReadOutGMTroubleCodes(String command) {
		WriteToPort(command);

		string[] Codes = WaitForFullResponse();
		foreach(string Code in Codes)
		{
			if(Code.Length > 16)
			{
				string HexCode = Code.Substring(12, 2) + Code.Substring(15, 2);
				if (HexCode != "0000") WriteToCodeView(ConvertDTCToString(HexCode));
			}
		}
	}
	
	public override void _Ready() {
		// Init UI elements
		portSelector = (OptionButton) GetNode("SerialPortSelector");
		baudSelector = (OptionButton) GetNode("BaudRateSelector");
		connectButton = (Button) GetNode("ConnectButton");
		connectButton.Connect("pressed", this, nameof(InitialisePort));
		
		codeView = (TextEdit) GetNode("TabContainer/Trouble Codes/CodeView");
		vehicleTypeSelector = (OptionButton) GetNode("TabContainer/Trouble Codes/VehicleTypeSelector");
		scanDTCButton = (Button) GetNode("TabContainer/Trouble Codes/ScanDTCButton");
		scanDTCButton.Connect("pressed", this, nameof(ScanDTCs));
		clearDTCButton = (Button) GetNode("TabContainer/Trouble Codes/ClearDTCButton");
		clearDTCButton.Connect("pressed", this, nameof(ClearDTCs));
		
		terminalView = (TextEdit) GetNode("TabContainer/Serial Terminal/LogView");
		terminalView.AddKeywordColor("Recv", new Color("#ff7300"));
		terminalView.AddKeywordColor("Send", new Color("#00ff00"));
		terminalInput = (LineEdit) GetNode("TabContainer/Serial Terminal/Input");
		terminalSendButton = (Button) GetNode("TabContainer/Serial Terminal/SendButton");
		terminalSendButton.Connect("pressed", this, nameof(SendTerminalData));
		
		logView = (TextEdit) GetNode("TabContainer/Log/LogView");
		
		WriteToLog("Looking for serial ports...");
		availablePorts = SerialPort.GetPortNames();
		foreach(string portname in availablePorts) {
			portSelector.AddItem(portname);
		}
	}

	public override void _Process(float delta) {
		if(Input.IsActionJustPressed("send"))
			SendTerminalData();    
	}
}
