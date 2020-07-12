# dnd.inventory

A very simple DnD inventory system, to experiment with, and learn from new solutions to common problems.

Common problems (and solutions):

* API DTO validation (https://www.nuget.org/packages/FluentValidation)
* Domain error handling (with exceptions and a middleware)
* Multi-tenancy (https://aspnetboilerplate.com/Pages/Documents/Multi-Tenancy)

Limitations:

* only API
* no tests

Capabilities:

* CRUD available items
* inventory of a single player (Add, Remove items)

Domain "solutions"/decisions:

* money is just another item
* items have no state (items in the inventory have a count property instead of adding it multiple times)
