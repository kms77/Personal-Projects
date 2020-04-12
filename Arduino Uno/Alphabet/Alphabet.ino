#include <LiquidCrystal.h>
LiquidCrystal lcd(7,8,9,10,11,12);
void setup() {
  lcd.begin(16,2);
  int x,ct=1,j=0,g=0;
  while(ct!=8)
       {
        x='a';
        g=0;
        while(g==0)
             {
              if(ct==1)
               {
                if(x=='i')
                   {
                   ct+=1;
                   j+=1;
                   }
               lcd.print(char(x));
               delay(500);
               lcd.setCursor(j,0);
               x+=1;
                }
              }
         lcd.setCursor(j,0);
       }
}
void loop() {
}
