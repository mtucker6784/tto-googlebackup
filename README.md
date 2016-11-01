[![Stories in Ready](https://badge.waffle.io/mtuckerinaz/tt-gdb.png?label=ready&title=Ready)](https://waffle.io/mtuckerinaz/tt-gdb)
# Tucker Tech Online's Google Apps Drive Backup (TTO-GDB)

[![Join the chat at https://gitter.im/mtuckerinaz/tt-gdb](https://badges.gitter.im/mtuckerinaz/tt-gdb.svg)](https://gitter.im/mtuckerinaz/tt-gdb?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
Tucker Tech's Free Google Apps Drive backup utility (TT-GDB) --- C# Drive API v3

Backup tool for backing up Google Apps Drive environments. This uses the Drive API v3 and C# (.net 4.5)

I developed this because I want to be able to backup my domain to my SAN & backup server. There are solutions out there, but they cost a lot of money and I'm still left in their hands. I also wanted a GUI friendly approach that I think others may be interested in the future.

This program will read a TXT file that contains only one column, which is where your useraccount@yourgappsdomain.xyz accounts are. It also supports a very rudimentary version of an LDAP AD connection. Type in your domain name in the preferences form, select an OU and let it go.

I have a lot of trial and error with this project (along with blood, sweat and tears), so I hope others may find it useful. I will always welcome PRs if you're interested in improving it.

Sites of interest: http://www.tuckertechonline.com/ , Particularly http://www.tuckertechonline.com/foss-google-drive-backup-directions/ ... There is more information + screenshots of what to do on that page.
Directions: 

The "core" code I used is mainly built on what Google already gives developers and can be found at the following URL: https://developers.google.com/drive/v3/web/quickstart/dotnet
I merely added some more "logic" to it to offer more flexibility.

At this time, I'm mainly concerned about backing up drive documents, so that's the only scope I'm pulling from, although you can really pull from any scope you want (email, drive, calendar, etc.) but those options are not native to this app yet. After figuring out how to restore directories, I plan to start working on backing up users' Gmail boxes.

Known issue(s) / concerns / future plans:

1. Create master log file for overall status. A log file is currently written for each user and streamed to their root drive directory.
2. Add restore directory (not just single file restore)
3. Parallel backup routine(s) to increase the backup performance.


If you download the source and plan to compile it, make sure to download the NuGet repository for the Google Apps Drive (v3) tools And MetroUI (this is free). This can be done by opening the NuGet manager in VS and typing in: "Install-Package Google.Apis.Drive.v3" (Without quotes), also search for Metro UI. There may be another step or two I'm forgetting, but feel free to ask and I'll be glad to help.

Binary download is on the releases page (https://github.com/mtucker6784/tto-googlebackup/releases)
See http://www.tuckertechonline.com/ for instructions + screenshots

Please understand that I know the code is very elementary, but I'd love collaboration on this!
I truly hope this helps others who are looking for a similar solution!

#Screens

<img src="https://cloud.githubusercontent.com/assets/1609106/19902445/0d5805e4-a028-11e6-9422-06b6e3a22e59.png"></img>
<img src="https://cloud.githubusercontent.com/assets/1609106/19902449/13e7a040-a028-11e6-9155-6cf37e7cfdd1.png"></img>
<img src="https://cloud.githubusercontent.com/assets/1609106/19902512/523ff414-a028-11e6-849e-cf84e872d239.png"></img>


