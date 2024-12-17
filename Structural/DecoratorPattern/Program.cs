// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

IFileSaver fileSaver = new EncryptFileSaver(new CompressFileSaver(new FileSaver()));
fileSaver.save(Environment.CurrentDirectory, "file stuff");
