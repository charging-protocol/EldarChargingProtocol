Eldar Charging Protocol

A protocol suite for EV charging infrastructure, designed to be developer-friendly.

Protocol 1 – Charger/Server Communication
Transport: JSON over WebSockets

Defines the communication between a Charging Station Management System and an EV charger.
Enables real-time control, transaction management, remote commands, and reporting.

Protocol 2 – CPO to Application Server Communication
Transport: JSON over REST

Defines the communication between a Charge Point Operator (CPO) backend and an application server API.
Provides station discovery, live availability, pricing, session control (start/stop), and user interaction endpoints.

