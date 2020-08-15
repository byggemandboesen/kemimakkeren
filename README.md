# Kemimakkeren
The purpose of this program is to save time plotting the concentration of a solution over time in the danish chemistry exam in "Gymnasium".

# Python
## Installing
Install git on your computer and copy the repository link. Open command prompt in your desired install directory and type the following:
```bash
git clone https://github.com/byggemandboesen/kemimakkeren.git
```
You can also clone the repository from GitHub directly.

## Dependencies
There are a few dependencies you need to install before using the program.
It's written in python so python 3.7 or earlier is recommended together with pip to install the required packages.
Remember to add python to "PATH" on installation. This will enable python to be available globally on your system.

### Packages
the following packages are required and they can all be installed with pip:
```bash
pip install scipy
pip install matplotlib
pip install numpy
pip install pandas
pip install xlrd
```
or by using the requirements.txt file included in the Python directory
```bash
cd Python
pip install requirements.txt
```

## How to use
To run the program, cd into your directory and open commandprompt.
Add the excel file to the input folder and run the program:
```bash
python Main.py
```
The output image files with each graph will be saved in the output folder.

# Windows forms (C# .NET)
The windows forms program is more versatile, and it can also be used to create graphs other than concentration/time such as absorbance to use for Lambert Beers law.

## How to use
The windows forms program can be found in the "Windows forms dot NET\Kemimakkeren\Kemimakkeren\bin\Debug" directory as "Kemimakkeren.exe".
It's not required to install any packages to run the .exe compared to the python program.

The program will save an Excel file called "Kemimakkeren.xlsx" in the same directory as the supplied/loaded Excel file. Furthermore, all the output chart/graphs will also be saved in this directory, which can be launched in file explorer by clicking the "Åben output placering" button.
