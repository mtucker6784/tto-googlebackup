# Tucker Tech Online GSuite backup
Tucker Tech's Free Google Apps Drive backup utility (TT-GDB) --- C# Drive API v3

Backup tool for backing up Google Apps Drive environments. This uses the Drive API v3 and C# (.net 4.5)

I developed this because I want to be able to backup my domain to my SAN & backup server. There are solutions out there, but they cost a lot of money and I'm still left in their hands. I also wanted a GUI friendly approach that I think others may be interested in the future.

This program will read a TXT file that contains only one column, which is where your useraccount@yourgappsdomain.xyz accounts are. It also supports a very rudimentary version of an LDAP AD connection. Type in your domain name and let it go.

I have a lot of trial and error with this project, but I've also put in a ton of love! I hope others may find it useful. I will always welcome PRs if you're interested in improving it.

Sites of interest: http://www.tuckertechonline.com/ , Particularly http://www.tuckertechonline.com/foss-google-drive-backup-directions/ ... There is more information + screenshots of what to do on that page. Directions:

The "core" code I used is mainly built on what Google already gives developers and can be found at the following URL: https://developers.google.com/drive/v3/web/quickstart/dotnet I merely added some more "logic" to it to offer more flexibility.

At this time, I'm mainly concerned about backing up drive documents, so that's the only scope I'm pulling from, although you can really pull from any scope you want (email, drive, calendar, etc.) but those options are not native to this app yet.

Known issue(s) / concerns / future plans:

Create master log file for overall status. A log file is currently written for each user and streamed to their root drive directory.
Complete Gmail archive functionality.
Hope this helps others who are looking for a similar solution!

Binary download is on the releases page (https://github.com/mtuckerinaz/Gapps-backup/releases) See http://www.tuckertechonline.com/ for instructions + screenshots

To compile this, you need to download the following from NuGet inside VS Google Drive API v3 Metro UI (FOSS Controls for Winforms)
