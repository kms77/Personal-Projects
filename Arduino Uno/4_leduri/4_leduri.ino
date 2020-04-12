int led1=12,led2=11,led3=10,led4=9;
void setup() {
   pinMode(led1,OUTPUT);
   pinMode(led2,OUTPUT);
   pinMode(led3,OUTPUT);
   pinMode(led4,OUTPUT);
}

void loop() {
  digitalWrite(led1,HIGH);
  digitalWrite(led4,LOW);
  delay(500);
  digitalWrite(led2,HIGH);
  digitalWrite(led1,LOW);
  delay(500);
  digitalWrite(led3,HIGH);
  digitalWrite(led2,LOW);
  delay(500);
  digitalWrite(led4,HIGH);
  digitalWrite(led3,LOW);
  delay(500);
}
