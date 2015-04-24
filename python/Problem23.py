import time;

# static map to use as a cache in dynamic programming
sIsAbundantNumberMap = {};

'''
  Returns true if the sum of the divisors of the number is greater than the number
  false otherwise
'''
def isAbundantNumber(number):
  if(number in sIsAbundantNumberMap):
    return sIsAbundantNumberMap[number];
  else:
    sum = 0;
    for i in range (1, int(number/2) + 1):
      if(number % i == 0):
        sum += i;
    sIsAbundantNumberMap[number] = sum > number;
    return sum > number;

'''
  12 is the first abundant number
  function returns true if it can be written as a sum of two abundant numbers
  and false if it cannot
'''
def canBeWrittenAsSumOfTwoAbundantNumbers(num):
  for i in range (12, num):
    num1 = i;
    num2 = num - i;
    if(isAbundantNumber(num1) & isAbundantNumber(num2)):
      return True;
  return False;

start = time.time();
sum = 0;

# All numbers greater than this number can be written as a sum of two abundant numbers
max = 28123;
for i in range (1, max + 1):
  if(not canBeWrittenAsSumOfTwoAbundantNumbers(i)):
    sum += i;

elapsed = time.time() - start;
print("Answer: %s found in %s seconds") % (sum, elapsed);

