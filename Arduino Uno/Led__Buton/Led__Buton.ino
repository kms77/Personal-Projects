#define LED 11
#define BUTTON 10
int i=0;
void setup() {
    pinMode(11,OUTPUT);
    pinMode(10,INPUT);
}
void loop() {
    i=digitalRead(BUTTON);
    if(i==HIGH)
      digitalWrite(LED,HIGH);
    else
      digitalWrite(LED,LOW);
}
