# UrhoSharp Sample Forked

This forked repository is to explain the situation in which reloading the UrhoSurface-included page leads application crash.

The point is holding `ResourceCache` reference in other instance than source `Application`.

I have checked it only in Android (Oreo), but it might happen in other OS.
