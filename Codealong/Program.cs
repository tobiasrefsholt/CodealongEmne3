// See https://aka.ms/new-console-template for more information

using Codealong;

var race = new Race(1000,3);
var horse1 = new Horse(20);
var horse2 = new Horse(30);
var horse3 = new Horse(45);

horse1.Feed();
horse2.TakeCareOf();
horse3.Feed();

race.AddHorse(horse1);
race.AddHorse(horse2);
race.AddHorse(horse3);

race.Start();