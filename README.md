# TIDAL downloader
for downloading video from TIDAL. ffmpeg required (assumes it's installed with Imagemagick, which probably isn't good).

TIDAL serves video in lots of 2-10s .ts clips, all with the same string before (and occasionally, as with Lemonade, after) the numbered clip. 
TIDAL downloader fetches these from TIDAL if you provide it with a prefix/suffix for the filename, saving them as [1, 2, 3, etc].ts in your chosen folder and stitching them together with 

You can get the URI segment (and suffix) by turning on developer tools in Google Chrome and watching part of the video you want to download at the quality you want. You'll get MIXED CONTENT warnings as it's playing, and the URI in these can be used to fetch video. They should end with [number].ts, and copying everything before this into "TIDAL URI segment" and setting the endpoint of the download to something at or above the number of files that make up the video (the downloader automatically detects if you go over though, so the default should be good - check that your session hasn't expired though).

For some videos (Lemonade is all that I've encountered), there's an extra string after the [number].ts - just add this to Suffix and you'll be fine (don't include the .ts)

After you've downloaded them all, enter a filename and hit Stitch. It's all H264, so ffmpeg can stitch the video files together without having to reencode and you'll have an mp4 file of the whole video.
