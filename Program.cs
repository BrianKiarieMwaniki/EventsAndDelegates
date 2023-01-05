global using EventsAndDelegates.Models;
global using EventsAndDelegates.Utils;
using EventsAndDelegates;
using EventsAndDelegates.Services;

var videoEncoder = new VideoEncoder();
var messageService = new MessageService(videoEncoder);
var emailService = new EmailService(videoEncoder);

videoEncoder.EncodeVideo(new Video());
