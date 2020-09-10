//jshint esversion:6

class account {

constructor(){
    this._balance = 0;
    this._accountName = "";
}
calculateSecurityToken(){}

getBalance(){
  return this._balance;
}


}

myAccount = new account();

myAccount._accountName = "Peter Frost";
var name = myAccount._accountName;

var balance = myAccount.getBalance();
