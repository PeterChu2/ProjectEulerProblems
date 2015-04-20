import time;

'''
  Calculates the alphabetical value of a string by using the ASCII value of its
  characters and subtracting the offset
'''
def alphabeticalValue(name):
  value = 0;
  charArray = list(name);
  for char in charArray:
    value += ord(char) - ord('A') + 1;
  return value;

start = time.time()

f = open('p022_names.txt', 'r');
NAMES = sorted(f.read().replace('"', '').split(','));
totalNameScores = 0;

for i in range(0, len(NAMES)):
  totalNameScores += (i+1)*alphabeticalValue(NAMES[i])

elapsed = time.time() - start
print("Answer: %s found in %s seconds") % (totalNameScores,elapsed)
