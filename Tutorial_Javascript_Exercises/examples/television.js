//jshint esversion:6

class television{

constructor(){
  this._screenSize = 0;
  this._voltage = 240;
  this._modelNo = 0;
  this._modelName = "";
  this._price = 0.00;
  this._volume = 9;
  this._colour = "white";
}

turnOn(){}
turnOff(){}
changeChannel(channelNumber){}
configureChannels(){}
changeVolume(volume){ this._volume = volume;}

}


const myTV = new television();
myTV._price = 100;

console.log(myTV);
