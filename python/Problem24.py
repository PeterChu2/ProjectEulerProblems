import time;
import itertools

start = time.time();

newlist = list(map("".join, itertools.permutations('0123456789')));
print newlist[999999];

elapsed = time.time() - start;
print "Elapsed time: %s" % (elapsed);
