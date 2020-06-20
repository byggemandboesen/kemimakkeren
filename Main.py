from scipy import stats
from matplotlib import pyplot as plt
from matplotlib.pyplot import figure
import numpy as np
import pandas as pd
import os

path = 'files/' + os.listdir('files')[0]
data = pd.read_excel(path)
row, col = data.shape
titler = data.columns
tid = data['Tid/s']
konc = []
stof = ''
ln_konc = []
konc_inv = []

for titel in titler:
    if titel[0] == '[':
        konc = data[titel]
        stof = titel

ln_konc = np.log(konc)
konc_inv = 1/konc
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
plt.savefig(fname='output.jpg', dpi=500)

plt.show()
