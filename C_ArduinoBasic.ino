int dirA = 12;
int dirB = 13;
int pwmA = 3;
int pwmB = 11;
int brakeA = 9;
int brakeB = 8;
String dir;
String as;

void setup() {
  // put your setup code here, to run once:
  pinMode(dirA ,OUTPUT);
  pinMode(dirB ,OUTPUT);
  pinMode(pwmA ,OUTPUT);
  pinMode(pwmB ,OUTPUT);
  pinMode(brakeA ,OUTPUT);
  pinMode(brakeB, OUTPUT);
  
  digitalWrite(brakeA, LOW);
  digitalWrite(brakeB, LOW);
  //Serial.begin(115200);
  Serial.begin(9600);
}

String message;

void loop() 
{
  // put your main code here, to run repeatedly:

  if(Serial.available())
  {
    dir = Serial.readString();
    as = dir;
  }
  
  if(dir == "FORWARD")
  {
    digitalWrite(dirA, HIGH);
    digitalWrite(dirB, HIGH);
    analogWrite(pwmA, 128);
    analogWrite(pwmB, 128);
    delay(1);
    analogWrite(pwmA, 0);
    analogWrite(pwmB, 0);
  }
  if(dir == "BACKWARD")
  {
    digitalWrite(dirA, LOW);
    digitalWrite(dirB, LOW);
    analogWrite(pwmA, 128);
    analogWrite(pwmB, 128);
    delay(1);
    analogWrite(pwmA, 0);
    analogWrite(pwmB, 0);
  }
  if(dir == "RIGHT")
  {
    digitalWrite(dirA, LOW);
    digitalWrite(dirB, HIGH);
    analogWrite(pwmA, 230);
    analogWrite(pwmB, 230);
    delay(1);
    analogWrite(pwmA, 0);
    analogWrite(pwmB, 0);
    //dir = "";
  }
  if(dir == "LEFT")
  {
    digitalWrite(dirA, HIGH);
    digitalWrite(dirB, LOW);
    analogWrite(pwmA, 230);
    analogWrite(pwmB, 230);
    delay(1);
    analogWrite(pwmA, 0);
    analogWrite(pwmB, 0);
    //dir = "";
  }
}
