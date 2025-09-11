using Calculator;

IConsoleAdapter consoleAdapter = new ConsoleAdapter();
IConsoleDataReader reader = new ConsoleDataReader(consoleAdapter);
IConsoleDataWriter writer = new ConsoleDataWriter(consoleAdapter);
ICalculatorCore calcCore = new CalculatorCore();
var calculatorHandler = new CalculatorConsoleHandler(reader, writer, calcCore);

calculatorHandler.Execute();