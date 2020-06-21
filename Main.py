from scipy import stats
from matplotlib import pyplot as plt
from matplotlib.pyplot import figure
import numpy as np
import pandas as pd
import os

# Tries to load excel file from input folder
def loadfile():
    try:
        path = 'input/' + os.listdir('input')[0]
        data = pd.read_excel(path)
    except IndexError:
        print('Please remember to include an excel file in the input folder')
        exit()
    return data


data = loadfile()
row, col = data.shape
titler = data.columns
tid = data['Tid/s']


# Gets column with solution concentration and its title
def getkonc(titler):
    for titel in titler:
        if titel[0] == '[':
            konc = data[titel]
            stof = titel
    return stof, konc

# Creates lists with natural log to concentration and inverse concentration for 1st and 2nd order reaction plot
stof, konc = getkonc(titler)
ln_konc = np.log(konc)
konc_inv = 1/konc

# Lists with concentrations and names for each order
koncentrationer = [konc, ln_konc, konc_inv]
stofnavne = [stof, f'ln({stof})', f'1/{stof}']


# For each loops through and plots all concentrations for 0, 1 and 2nd order and saves as JPG
i = 0
for konc, stof in zip(koncentrationer, stofnavne):
    print(f'{(i/3)*100}% finished')
    slope, intercept, r_value, p_value, std_err = stats.linregress(tid, konc)
    lin_reg = slope * tid + intercept
    lin_reg_str = str(f'{round(slope, 10)}x+{round(intercept, 10)}')

    figure(figsize=(16, 9))
    plt.title(f'{stof}', fontsize=25)
    plt.xlabel('Tid/s', fontsize=18)
    plt.ylabel(f'{stof}/M', fontsize=18)

    plt.plot(tid, lin_reg, linestyle='dotted', color='red')
    plt.scatter(tid, konc, color='green')
    ax = plt.gca()
    ax.ticklabel_format(useOffset=False, style='plain')
    plt.grid(True)

    legend = ('Lineær tilpasning\nf(x)={0}\nr-værdi = {1}'.format(lin_reg_str, abs(round(r_value, 5))), 'Målt data')
    plt.legend(legend, fancybox=True, borderpad=1, shadow=True, fontsize=14)
    plt.savefig(fname=f'output/Orden - {i}.jpg', dpi=500)
    i += 1

print('100% finished.\nGraphs are saved in the output folder.')
