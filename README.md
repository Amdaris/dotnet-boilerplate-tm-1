# Backend Boilerplate

Use it for setting up a take-home interview assignment or a portfolio project.

## How to run project
For building and starting up the project: 
- dotnet build
- dotnet run --project .\backend\backend.csproj

If you're using codespace, you'll see a popup in the bottom right corner asking for permission to open a new tab in your browser. On this new tab navigate to `/swagger`, and you'll be able to test your solution here.


## Contents

- [Backend service](https://github.com/DevSkillsHQ/backend-boilerplate-dotnet/tree/master/app) - an .NET service with a `/ping` endpoint. Extend with your code.
- [API test suite](https://github.com/DevSkillsHQ/backend-boilerplate-dotnet/blob/master/cypress/integration/backend.spec.js) - a Cypress test suite. Extend with your tests.
- [Pipeline](https://github.com/DevSkillsHQ/backend-boilerplate-dotnet/blob/master/.github/workflows/tests.yml) - a test Runner that executes the Cypress tests on push to a branch other than `master`/`main`.

## Tech Stack

- .NET7
- Cypress
- GitHub Actions

---

Made by [DevSkills](https://devskills.co).

Did you find this repo useful? **Give us a shout on [Twitter](https://twitter.com/DevSkillsHQ) / [LinkedIn](https://www.linkedin.com/company/devskills)**.

