# swap two numbers in a lst
def swap(lst, a, b):
  lst[a], lst[b] = lst[b], lst[a]
# find a partitioning point within the array
def bleh(A, p, q):
  r = A[q]
  i = p - 1
  for j in range(p, q):
    if (A[j] < r):
      i += 1
      swap(A, i, j)
  if (A[q] < A[i + 1]):
    swap(A, i+1, q)
  return i + 1
def quuz(A, x, y):
  if (x < y):
    z = bleh(A, x, y)
    quuz(A, x, z-1)
    if (z < y):
      quuz(A, z+1, y)
def corge(A, n):
  quuz(A, 0, n-1)