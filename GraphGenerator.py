import numpy as np
import matplotlib.pyplot as plt


#Kod koji generira graf matematičke funkcije - primjer za f(x)=ctg(x)
#definicija funkcije je generirana pomoću http://latex2png.com/
fig = plt.figure()
x = np.linspace(0,np.pi-0.1,30)
y = 1.0/np.tan(x)

ax = fig.add_subplot(1, 1, 1)
ax.plot(x, y, linewidth=3, color="darkblue")
ax.axis('equal')
ax.spines['left'].set_position('zero')
ax.spines['right'].set_color('none')
ax.spines['bottom'].set_position('zero')
ax.spines['top'].set_color('none')
ax.spines['left'].set_smart_bounds(True)
ax.spines['bottom'].set_smart_bounds(True)
ax.xaxis.set_ticks_position('bottom')
ax.yaxis.set_ticks_position('left')
ax.axhline(linewidth=2, color="black")
ax.axvline(linewidth=2, color="black")

plt.show()

