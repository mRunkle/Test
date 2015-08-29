regularHours = raw_input("How many hours is your regular work week?")
hours = raw_input("How many hours did you work this week?")
rate = raw_input ("How much do you make per hour?")

try:
    regularHours = float(regularHours)
    hours = float(hours)
    rate = float(rate)
except:
    print "Invalid Entry:"
	
pay = 0
payCheck = 0

def computePay(h, r):
    if h > regularHours:
        pay = (regularHours * rate) + ((hours - regularHours) * (rate * 1.5))
        return pay
    else:
        pay = regularHours * rate
        return pay

try:		
    payCheck = computePay(hours, rate)
    print payCheck
except:
    print "Please enter a number."