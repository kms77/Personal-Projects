#define LED1 9
#define LED2 8
void setup() {
  pinMode(LED1,OUTPUT);
  pinMode(LED2,OUTPUT);
}
void loop() {
  digitalWrite(8,HIGH);
  digitalWrite(9,LOW);
  delay(2000);
  digitalWrite(8,LOW);
  digitalWrite(9,HIGH);
  delay(2000);
}
