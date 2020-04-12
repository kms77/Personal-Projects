int led1=9,led2=5;
void setup() {
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
}
void loop() {
   digitalWrite(led1,HIGH);
   digitalWrite(led2,LOW);
   delay(2000);
   digitalWrite(led1,LOW);
   digitalWrite(led2,HIGH);
}
