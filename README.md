# SiemensPLC-Visualisation
Simple HMI application to visualize state of PLC tags. Originaly written in late 2015, so might be slightly outdated.

This is a very simple visualisation system based on Snap7 (http://snap7.sourceforge.net/). 
It is assumed that the reader is familiar with data concepts in Siemns Step 7 software and Siemens PLCs.
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

There are events for two buttons. One to scan the tag list and populate the controls once. Second to enable the "ONLINE" mode which
polls PLC for tags every 1 second. This time can be changed in Online Mode section of the code.

<h3> 2. Online Mode </h3>
Online mode is a based on a BackgroundWorker. It polls the PLC for tags every set time configured by changing the Thread.Sleep() value. Simple yet effective way to read data from the PLC. One second poll is widely use standard poll time for commercial visualisation systems.

<h3> 3. User Scripts </h3>
This section is dedicated to interaction with the visualisation elements. If a change to control is required (for instance colour of the text box depending on tag value) then this interaction should be programmed here. For example - changing a picture on a Image Box is achieved by:

            if (bi_e63_0.State)
            {
                pb_Switch2.Image = Image.FromFile("Resources/Conveyor_Icon_Switch_0.bmp");
            }
            
In this example an indicatior (specially made control on the form, available as DLL) named bi_e63_0 drives change of picture in the Push Button image.
 
<h3> 4. Visualisation Interface </h3>
The concept of data display is as follows. In the main form we have TabPage (tp_visual) which contains all the controls (text boxes, pushbutton, indicators and so on). Controls have unique and discriptive names for instance:
 
        bi_e63_0 - binary indicator e63.0 (which indicates PLC input 63.0 - "e" is for german mnemonic notation)
        bi_a64_7 - binary indicator a64.7 (which indicates PLC output 64.7 - "a" is for german mnomonic notation)

Tag list have to duplicate those names so that PLC addresses can be binded with the controls during polling process. The tag list (placed in tags.ini file) has the following form:

        [TAG]
        2;0;64;7;0;0;bi_a64_7;Right Run Ready
        2;0;63;0;0;0;bi_e63_0;Automatic Mode ON
        ....
 
The structure of each tag definition is: 
 
        type; db address; start; length; bit;  representation; control Name; displayName
        
        type: 0 = DB, 1 = Input, 2 = Output; 3 = Marker/Flag
        
        representation: 0 = boolean, 1 = integer, 2 = char, 3 = (siemens) string, 4 = word (8bit), 5 = char array
 
