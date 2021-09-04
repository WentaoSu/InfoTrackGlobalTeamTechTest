@BookingTestsTag
Feature: Create bookings

Scenario: Morning
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 09:00       | Wentao Su |
	Then the booking api returns http status code: 201
	Then the successful new booking count is: 1

Scenario: Before Closure
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 16:01       | Wentao Su |
	Then the booking api returns http status code: 201
	Then the successful new booking count is: 1

Scenario: 4 X same time slot
	Given There're below bookings:
	| BookingTime | Name      |
	| 10:00       | Wentao Su |
	| 10:00       | Wentao Su |
	| 10:00       | Wentao Su |
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 10:00       | Wentao Su |
	Then the booking api returns http status code: 201
	Then the successful new booking count is: 1

Scenario: Double Overlapping
	Given There're below bookings:
	| BookingTime | Name      |
	| 12:00       | Wentao Su |
	| 11:30       | Wentao Su |
	| 12:30       | Wentao Su |
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 12:00       | Wentao Su |
	Then the booking api returns http status code: 201
	Then the successful new booking count is: 1

Scenario: Negative - Invalid input, time as text
	When A new booking is made with below details:
	| BookingTime | Name      |
	| abc         | Wentao Su |
	Then the booking api returns http status code: 400

Scenario: Negative - Invalid input, empty name
	When A new booking is made with below details:
	| BookingTime | Name |
	| 12:00       |      |
	Then the booking api returns http status code: 400

Scenario: Negative - Out of business hour, early
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 08:00       | Wentao Su |
	Then the booking api returns http status code: 400
	Then the successful new booking count is: 0

Scenario: Negative - Out of business hour, early partial
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 08:30       | Wentao Su |
	Then the booking api returns http status code: 400
	Then the successful new booking count is: 0

Scenario: Negative - Out of business hour, late
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 17:00       | Wentao Su |
	Then the booking api returns http status code: 400
	Then the successful new booking count is: 0

Scenario: Negative - Out of business hour, late partial
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 16:30       | Wentao Su |
	Then the booking api returns http status code: 400
	Then the successful new booking count is: 0

Scenario: Negative - 5 X Same time slot 
	Given There're below bookings:
	| BookingTime | Name      |
	| 13:00       | Wentao Su |
	| 13:00       | Wentao Su |
	| 13:00       | Wentao Su |
	| 13:00       | Wentao Su |
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 13:00       | Wentao Su |
	Then the booking api returns http status code: 409
	Then the successful new booking count is: 0

Scenario: Composite tests 
	Given There're below bookings:
	| BookingTime | Name      |
	| 14:00       | Wentao Su |
	| 14:15       | Wentao Su |
	| 14:30       | Wentao Su |
	| 14:45       | Wentao Su |
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 14:00       | Wentao Su |
	Then the booking api returns http status code: 409
	Then the successful new booking count is: 0
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 14:59       | Wentao Su |
	Then the booking api returns http status code: 409
	Then the successful new booking count is: 0
	When A new booking is made with below details:
	| BookingTime | Name      |
	| 15:00       | Wentao Su |
	Then the booking api returns http status code: 201
	Then the successful new booking count is: 1