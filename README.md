# EventsAndDelegates
This a simple C# console app I have built to practice C# Events and Delegates language features.
Hoping to have a blust while doing this.

## The Application
This project simulates a video encoding application that sends a video via an email service and SMS service to
a user once the video encoding is done. The class VideoEncoder is my event publisher and EmailServices and
MessageService classes are my subscribers.

The event published is the OnVideoEncoded. Its takes the VideoEventArgs as a parameter. These event args can be accessed by my 
subscriber classes.
Once the encoding is done in the EncodeVideo method, the event is invoked and my subscribers can get hold of the encoded video
and simulate a send to your function.
