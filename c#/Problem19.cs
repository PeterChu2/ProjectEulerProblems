using System;
class Problem19
{
    static void Main()
    {
        int sundaysElapsed = 0;

        ExecutionTimer.start();
        // determine the number of days that have passed between Jan. 1 1900 and
        // Jan 1 1901
        int daysElapsedFrom1900To1901 = daysElapsed(1900, 1901);

        // Determine what day of the week Jan 1 1901 falls on
        int startDay = (daysElapsedFrom1900To1901) % 7;
        if(startDay == 6) {
            sundaysElapsed++;
        }

        // determine the number of days that have passed between Jan. 1 1901 and
        // Dec. 31 2000
        // subtract 1 because it is one less day that to Jan 1. 2001
        int daysElapsedFrom1901To2000 = daysElapsed(1901, 2001) - 1;

        // Determine what day of the week Jan 1 2001 falls on
        int offset = daysElapsedFrom1901To2000 % 7;
        String endDay = dayOfWeek(startDay, offset);

        Console.WriteLine("From " + dayOfWeek(startDay) + ", Jan 1, 1901 to " +
            endDay + ", Dec 31, 2000:");

        for(int i = 1901; i <= 2000; i++) {
            for(int j = 1; j <= 12; j++) {
                startDay = (startDay + daysInMonth(j, i)) % 7;
                if(startDay == 6) {
                    sundaysElapsed++;
                }
            }
        }

        Console.WriteLine(sundaysElapsed + " Sundays fell on the first of the" +
            " month during the twentieth century");
        ExecutionTimer.stop();
    }

    /*
        Returns the number of Days Elapsed since Jan. 1 of startYear to Jan. 1 of endYear
    */
    private static int daysElapsed(int startYear, int endYear) {
        int totalDaysElapsed = 0;
        for(int i = startYear; i < endYear; i++) {
            for(int j = 1; j <= 12; j++) {
                totalDaysElapsed += daysInMonth(j, i);
            }
        }
        return totalDaysElapsed;
    }

    /*
        Returns the number of days in the month specified by an integer, month,
        where month ranges from 1 (Jan) to 12 (Dec)
    */
    private static int daysInMonth(int month, int year) {
        if((month < 1)||(month > 12)) {
            throw new System.ArgumentException("Parameter must be from 1-12", "month");
        }
        if(month == 4 || month == 6 || month == 9 || month == 11) {
            return 30;
        }
        if(month == 2) {
            if(isLeapYear(year)) {
                return 29;
            }
            else {
                return 28;
            }
        }
        // the rest of the months have 31
        return 31;
    }

    /*
        Returns true if the year is a leap year, otherwise false
    */
    private static bool isLeapYear(int year) {
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0)) {
            return true;
        }
        return false;
    }

    /*
        Encodes the day of the week, day, represented as an integer from
        0 (Monday) to 6 (Sunday) to its string representation
    */
    private static String dayOfWeek(int day) {
        switch(day) {
            case 0:
                return "MONDAY";
            case 1:
                return "TUESDAY";
            case 2:
                return "WEDNESDAY";
            case 3:
                return "THURSDAY";
            case 4:
                return "FRIDAY";
            case 5:
                return "SATURDAY";
            case 6:
                return "SUNDAY";
            default:
                return "INVALID";
        }
    }

    /*
        Determines the day of week from a startDay and an offset
    */
    private static String dayOfWeek(int startDay, int offset) {
        int endDay = startDay + offset;
        if(endDay > 6) {
            endDay -= 7;
        }
        return dayOfWeek(endDay);
    }

    /*
        Determines if Sunday has passed after an offset number of days after
        startDay
    */
    private static bool hasSundayPassed(int startDay, int offset) {
        int endDay = startDay + offset;
        if(endDay > 7) {
            return true;
        }
        return false;
    }
}
