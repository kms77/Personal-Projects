#define iza 11
void setup() {
   pinMode(iza,OUTPUT);
}
void loop() {
  digitalWrite(iza,HIGH);
  delay(2000);
  digitalWrite(iza,LOW);
  delay(2000);
}
