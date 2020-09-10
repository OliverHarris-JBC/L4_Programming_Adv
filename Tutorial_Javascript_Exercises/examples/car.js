//jshint esversion:6
class Car {
  constructor() {
    this._engine = new Engine();
    this._colour = "white";
    this._price = 0.99;
  }
}

class Engine{
  constructor(){
    this._engineSize = 0;
  }
  setEngineSize(size){
    this._engineSize = size;
  }
}


myCar = new Car();

myCar.engine.setEngineSize(1800);
