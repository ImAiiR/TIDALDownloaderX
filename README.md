<p style="align:center;">
  <a href="https://github.com/ImAiiR/TIDALDownloaderX">
    <img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/TDX-1.png" />
  </a>
</p>

Modified from <a href="https://github.com/italicsjenga/TidalDownloader">TidalDownloader</a> by <a href="https://github.com/italicsjenga/">Alex Janka</a>

<p style="align:center;">
  <a href="https://github.com/ImAiiR/TIDALDownloaderX">
    <img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/screen1.jpg" />
  </a>
</p>

## About
TIDALDownloaderX is a simple C# program for downloading videos from the streaming platform <a href="https://tidal.com/">TIDAL</a>.

TIDAL serves videos in segments of 2-10 second .ts files, all with the same string before (and occasionally, after) the numbered clip.

TIDALDownloaderX takes the first link that TIDAL sends to the user, and downloads the following .ts files, until it has completed downloading all .ts files relating to that video.

## Tutorial (Updated August 2nd, 2019)

**YOU NEED A PAID TIDAL ACCOUNT. THIS TOOL DOES NOT GIVE YOU ACCESS TO CONTENT YOU HAVEN'T PAID FOR!** 

To start, make sure you have the exe for this program in the spot you want it to be, and be logged into TIDAL on a web browser of your choice. This tutuorial will go based off of Google Chrome. Most browsers should work, so just try to replicate everything here. Let's get started.

**STEP 1** <br />
Open TIDALDownloaderX, and start off by clicking ```Download Needed Files```. This will download the required tools to merge the .ts files we download.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step1.png" />

**STEP 2** <br />
Go ahead and click ```Choose Folder```, and then select the folder you would like to download the .ts files to. Make sure this is a place that has a lot of space, as the files downloaded could be large. Keep that in mind.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step2.png" />

**STEP 3** <br />
Head over to your web browser, and open <a href="https://listen.tidal.com/">TIDAL</a>. Once logged in, go ahead and search for the Artist / Band you want to download videos for. In this example, I'll use Alec Benjamin, and I'll get the video "Jesus in LA". If you want to use the same video to learn, feel free. The artist page can be found <a href="https://listen.tidal.com/artist/4895800">HERE</a>.<br />
Now before we click on the video, bring up the Developer Tools of your browser, and select the ```Network``` tab, and make sure the ```All``` option is selected. Once there, find the search bar, and type in ```0.ts```. This is so when the video starts, any results for a URL with 0.ts in it will show up.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step3.png" />

**STEP 4** <br />
**If this is your first time, as you'll need to quickly switch the quality to what you want once the video page pops up, or else the quality will be set to ```Auto```. After doing this once, the option you selected should be the default for the next times you do this.**<br />
Whenever you're ready, click on the video to make it start playing. Look at the network results, and once you get results, go ahead and pause the video playback.
Now on the Network tab, go to the very last link found that has ```0.ts``` in it (make sure it's not ```10.ts```), then copy the URL. Once you do this, you'll be done with the web browser. I don't suggest closing it, as that may affect the download.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step4.png" />

**STEP 5** <br />
Now back to TDX, paste the link you just copied into the textbox at the top, and click ```Set URL```. The output on the side should say ```URL Set!```.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step5.png" />

**STEP 6** <br />
Before starting the download, go ahead and click ```Move Files```, so that the files you downloaded earlier are now in your chosen directory. Once you've done that, you can then click ```Download```, and watch as the output to the right tells you how many sections are being downloaded. You'll know everything is done when you see ```Job Completed!```<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step6.png" />

**STEP 7** <br />
Next up, click ```Open JAMSTA```, and follow the directions on the command window that opens. Once you do all of the options, the command window should close, and you'll have a finished video.<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step7.png" />

**STEP 8** <br />
You can now click ```Open Folder```, and find ```JAMSTA.mp4``` to get your full video. Name it whatever you want, and you're done!<br />
<img src="https://raw.githubusercontent.com/ImAiiR/TIDALDownloaderX/master/-assets/Step8.png" />
