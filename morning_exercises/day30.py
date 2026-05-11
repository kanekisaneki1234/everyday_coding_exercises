class TimeMap:
    def __init__(self, key=None, value=None, timestamp=None):
        self.store = {}

    def set(self, key, value, timestamp):
        if key not in self.store:
            self.store[key] = []
        self.store[key].append([timestamp, value])

    def get(self, key, timestamp):
        # if key in self.store:
        #     return self.store[key]
        # else:
        #     return ""
        if key in self.store:
            # return self.store[key]
            left = 0
            right = len(self.store[key])-1

            if timestamp>self.store[key][right][0]:
                return self.store[key][right][1]
            if timestamp<self.store[key][left][0]:
                return ""

            while (left<=right):
                mid = (left+right)//2

                if timestamp==self.store[key][mid][0]: return self.store[key][mid][1]
                elif timestamp>self.store[key][mid][0]:
                    result = self.store[key][mid][1]
                    left = mid+1
                else: right = mid-1

            return result

            # while left <= right:
            #     mid = (left + right) // 2
            #     if self.store[key][mid][0] <= timestamp:
            #         result = self.store[key][mid][1]  # valid, save it
            #         left = mid + 1                    # try to find something closer
            #     else:
            #         right = mid - 1
            # return result

        else:
            return ""


test = TimeMap()
# test.set("1", "2", 1)
# test.set("1", "3", 4)
# test.set("1", "4", 6)
# test.set("1", "5", 8)

# test.set("1", "2", 5)
# test.set("1", "3", 6)
# # test.set("1", "4", 7)
# test.set("1", "5", 8)
# test.set("1", "6", 9)
# test.set("1", "7", 10)

test.set("1", "aaa", 5)
print(test.get("1", 3))

# print(test.get("1", 7))