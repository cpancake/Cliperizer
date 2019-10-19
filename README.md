# Cliperizer

This is a project I started and finished about two months ago or so (at the time of this writing). It's a program for easily creating clips out of larger videos. Maybe you're making a clip show out of your home movies. Maybe you're making clips of a movie to upload individually to reddit and get your gfycat account flagged. Maybe you're going to use this to create your Hobbit fan edit (don't do this).

## Usage

Download the archive from releases ([right here](https://github.com/cpancake/Cliperizer/releases/tag/v1.0.0)). This is the binary. I don't know what platforms it's compatible with, but I know it works with mine. If it doesn't work for yours, build it on your own (and tell me, please, so I can add a binary that works for you). You'll need `ffmpeg` installed and in your path, so get that for whatever system you have. You might need VLC too, I dunno.

Using this is pretty simple. Create a new project and select a video file. This will bring up the main clip editing window. Press space to pause and play. Drag the bar at the bottom to move to different positions in the video. Press "1" (that's the number one, at the top of your keyboard) to set the start point to a clip. Press "2" to set the end point. When you create a clip, a prompt will come up to name the clip. If you want to edit or delete a clip you've already made, press "List Clips." If you want to finish up and render out the clips, click on "Render," select the clips you want to render, select the quality and the format you want to export them in, select the output directory, and then either "Render" (renders each clip as a seperate file) or "Render and Concat" (renders each clip as a seperate file and then concatenates them together into one big clip along side it). Then just give it a second.

## License

Copyright (c) 2016 Ashley Rogers

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
