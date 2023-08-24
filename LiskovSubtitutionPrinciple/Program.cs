// See https://aka.ms/new-console-template for more information
using LiskovSubtitutionPrinciple;



IFileRead accessData = new AdminFileUser();
accessData.ReadFile();

IFileWrite accessDat = new AdminFileUser();
accessDat.WriteFile();


IFileRead accessDataRead = new NormalFileUser();
accessDataRead.ReadFile();

Console.Read();
