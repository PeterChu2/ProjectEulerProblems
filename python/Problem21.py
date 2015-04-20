from math import ceil;
import time;

def sumOfProperDivisors(n):
  sum = 0;
  for i in range(1, int(ceil(n/2)) + 1):
    if n % i == 0:
      sum += i;
  return sum;

def sumPairs(pairs):
    return sum([sum(pair) for pair in pairs])

def amicablePairsInRange(low,high):
    L = [sumOfProperDivisors(i) for i in range(low,high + 1)]
    pairs = []
    for i in range(high - low + 1):
        ind = L[i]
        if i + low < ind and low <= ind and ind <= high and L[ind - low] == i + low:
            pairs.append([i+low,ind])
    return pairs

start = time.time()

ans = sumPairs(amicablePairsInRange(1,10000))

elapsed = time.time() - start

print("Answer: %s found in %s seconds") % (ans,elapsed)
