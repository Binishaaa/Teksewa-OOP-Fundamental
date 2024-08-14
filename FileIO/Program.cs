var fileHandler = new FileHandler();
fileHandler.ReadFile();

fileHandler.WriteFile();

var emps = fileHandler.ReadFile();

fileHandler.WriteEmployeeToFile(emps);
