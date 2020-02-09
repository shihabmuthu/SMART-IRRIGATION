int m=0;
void setup() {
  // put your setup code here, to run once:
pinMode(A0, INPUT_PULLUP);
pinMode(8,OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:

int m= analogRead(A0);
Serial.println(m);
delay(200);
if (m>=980)
{
  digitalWrite(8, LOW);
  
  }

else if(m<=970)
{

  digitalWrite(8, HIGH);
  }
  
else
{
  digitalWrite(8, HIGH);
  }
}
