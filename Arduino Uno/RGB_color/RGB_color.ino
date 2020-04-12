int Redpin=11,Bluepin=9,Greenpin=10;
void setup() {
   pinMode(Redpin,OUTPUT);
   pinMode(Greenpin,OUTPUT);
   pinMode(Bluepin,OUTPUT);
}
void loop() {
  setColor(153,0,255);
  delay(1000);
  setColor(0,0,255);
  delay(1000);
  setColor(255,0,0);
  delay(1000);
  setColor(0,255,0);
  delay(1000);
}
void setColor(int Redvalue,int Greenvalue,int Bluevalue)
{
  analogWrite(Redpin,Redvalue);
  analogWrite(Greenpin,Greenvalue);
  analogWrite(Bluepin,Bluevalue);
}
