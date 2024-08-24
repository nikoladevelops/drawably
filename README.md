<h1>Drawably - simple drawing application</h1>


This is a practice application and you are free to do whatever you like with it. It is heavily inspired by <a href="https://www.getpaint.net/" target="_blank" style="text-decoration:none; color:#007ACC; font-weight:bold;">
    Paint.NET
</a>.<br>
I do not own any of the icons used so you should check out the `credits.txt` file.<br><br>
Technlogies used: <strong>Windows Forms</strong> with <strong>.NET 6</strong></h2>

![image](https://github.com/user-attachments/assets/9086df50-4bc6-457f-b58f-102cfe98f02c)

<h2>Supported features:</h2>

<h3>Draggable windows</h3>
Available windows: <strong>Colors Window</strong>, <strong>Layers Window</strong> and <strong>Tools Window</strong>. They are all draggable and you can also hide/show them.

<h3>Layers</h3>
<h5>Layers support Z index ordering.</h5>
<h5>How does it work?</h5>
Each layer is just a bitmap. I also have a displayed image bitmap which is basically all layer bitmaps merged into a single one and then displayed on the canvas. The Z index ordering relies on the ordering of the labels inside the Layers Window. There are lots of
small details like when do you update the displayed image, how do you ensure that you are drawing on the selected layer at all times and so on.. but I'm fairly confident that the code documentation is enough to figure it out.

<h5>Functionality:</h5>
<ul>
    <li><strong>Create New Layer</strong></li>
    <li><strong>Delete Layer</strong></li>
    <li><strong>Duplicate Layer</strong></li>
    <li><strong>Move Layer Up</strong></li>
    <li><strong>Move Layer Down</strong></li>
   <li><strong>View/Hide Layer</strong></li>
</ul>

<h3>Colors</h3>
<h5>Functionality:</h5>
<ul>
    <li><strong>Left Color</strong></li>
    <li><strong>Right Color</strong></li>
    <li><strong>Switching left and right color</strong></li>
    <li><strong>Color opacity</strong></li>
</ul>

<h3>Tools:</h3>

<h5>Select Shape Tool</h5>
Allows you to select generated shapes and move them around the screen.
<h5>Pen Tool</h5>
Allows you to draw with a brush size of 1px.
<h5>Brush Tool</h5>
Allows you to draw with a chosen brush size.
<h5>Draw Shapes Tool</h5>
Allows you to easily generate shapes with a given width and height. Supported shapes are: <strong>Rectangle</strong>, <strong>Circle</strong>, <strong>Normal Triangle</strong> and <strong>Right Triangle</strong>.
<h5>Zoom In Tool</h5>
Allows you to <strong>zoom in</strong> on the canvas. <strong>Hotkey: CTRL + MOUSE SCROLL WHEEL UP. <strong>
<h5>Zoom Out Tool</h5>
Allows you to <strong>zoom out</strong> on the canvas. <strong>Hotkey: CTRL + MOUSE SCROLL WHEEL DOWN. <strong>

<h3>Canvas:</h3>
The canvas supports resizing.

<h3>Known Issues:</h3>
<ul>
  <li>Performance is a big Issue, especially when the canvas is zoomed in fully. This is because of the Graphics.DrawImage() method that also handles scaling internally.</li>
  <li>Scroll bars are not re-positioned correctly upon resizing.</li>
  <li>Sometimes when resizing the mouse coordinates don't match the graphics' coordinates which causes wrong mouse position drawing (fixed if you resize a couple of times).</li>
  <li>Lots of useful features missing - fill color bucket tool, color picker, text rendering, layer re-naming, different image export formats, saving the project on disk and being able to return to it any time you would like, rotating shapes, being able to copy/paste images from clipboard, history for all changes applied to the canvas and much more..</li>
</ul>

This was a practice project so I don't plan on improving it. In the first place using Windows Forms for a drawing application is a bad idea, because GDI+ is not hardware-accelerated, not to mention that you can only run the app on Windows. Still, it was a fun little challenge to tackle.
