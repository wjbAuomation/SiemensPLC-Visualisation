# SiemensPLC-Visualisation
Simple HMI application to visualize state of PLC tags. Originaly written in late 2015, so might be slightly outdated.

This is a very simple visualisation system based on Snap7 (http://snap7.sourceforge.net/). 
The interface has to be created using Visual Studio. Tag lists can be imported into the project using text file. 

The program is divided into following parts:
<ol>
<li>Visualisation Functions</li>
<li>Online Mode</li>
<li>User Scripts</li>
<li>Visualisation Interface</li>
</ol>
<h3> 1. Visualisation Functions </h3>
This is the core of the software. Here we establish connection, read config file and utilize the functions of the Snap7.

There are two variables that have to be edited - IP address of the PLC and the name of the tag file definition (it has to 
be placed in the .exe root directory).

    private string sHostIP = "10.93.158.12";
    private string sTagFile = "tags.ini";

There are events for two buttons. One to scan the tag list and populate the controls once. And second to enable the "ONLINE" mode which
polls PLC for tags every 1 second. This time can be changed in Online Mode section of the code.

<h3>2. Online Mode</h3>
Online mode is a based on a BackgroundWorker. It polls the PLC for tags every set time configured by changing the Thread.Sleep() value. Simple yet effective way to read data from the PLC. One second poll is widely use standard poll time for commercial visualisation systems.
