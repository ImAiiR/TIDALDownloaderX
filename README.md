# TIDALDownloaderX
For downloading videos from TIDAL.

[THIS README IS OUTDATED, AND WILL BE FIXED LATER.]

Modified from TidalDownloader, here - https://github.com/italicsjenga/TidalDownloader

TIDAL serves videos in segments of 2-10s .ts files, all with the same string before (and occasionally, after) the numbered clip.

TIDALDownloaderX fetches these from TIDAL, as long as you provide it with the starting link. In this case, the first .ts segment, with [0.ts] in it's link. TIDALDownloaderX will begin saving them as [1, 2, 3, etc].ts in your chosen folder. 

You can get the starting link by turning on [Developer Tools] in Google Chrome, and start playing part of the video you want to downloadd (in the quality you want). You want to copy the link that includes [0.ts], and set the [End] value to something at or above the number of files that makes up the video. The program automatically detects if you go over, so the default should be fine, but check that your session hasn't expired.

After you've downloaded them all, click [Stitch], then follow the directions given.

(This tool is in development at the moment. Somethings will not work preoperly, or may not be correct in this README.)
