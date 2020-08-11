# Kemimakkeren
The purpose of this program is to save time plotting the concentration of a solution over time in the danish chemistry exam in "Gymnasium".

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

## Running the program
To run the program, cd into your directory and open commandprompt.
Add the excel file to the input folder and run the program:
```bash
python Main.py
```
The output image files with each graph will be saved in the output folder.
