# SiemensPLC-Visualisation
Simple HMI application to visualize state of PLC tags. Originaly written in late 2015, so might be slightly outdated.

This is a very simple visualisation system based on Snap7 (http://snap7.sourceforge.net/). 
The interface has to be created using Visual Studio. Tag lists can be imported into the project using text file. 

The program is divided into following parts:

<ol>
<li>Visualisation Functions</li>
<li>Online Mode</li>
<li>User Scripts</li>
</ol>

<h3> 1. Visualisation Functions </h3>
This is the core of the software. Here we establish connection, read config file and utilize the functions of the Snap7.

There are two variables that have to be edited - IP address of the PLC and the name of the tag file definition (it has to 
be placed in the .exe root directory.

    private string sHostIP = "10.93.158.12";
    private string sTagFile = "tags.ini";
