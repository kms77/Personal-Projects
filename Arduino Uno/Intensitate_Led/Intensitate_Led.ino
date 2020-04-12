#define LED 11 
void setup() { 
    pinMode(11,OUTPUT);
}
void loop() {
    int i;
    for(i=0;i<=255;i++)
        {
         analogWrite(LED,i);
        }
    for(i=255;i>=0;i--)
        {
          analogWrite(LED,i);    
        }
}
