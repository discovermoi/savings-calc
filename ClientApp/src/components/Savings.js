import React, { Component } from "react";

export class Savings extends Component {
  static displayName = Savings.name;

  constructor(props) {
    super(props);
    this.state = { savings: [], loading: true };
  }

  componentDidMount() {
    this.populateSavingsData();
  }

  static renderSavingsInformation(savings) {
    return <h1>This will be the UI</h1>;
  }

  render() {
    let contents = this.state.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      Savings.renderSavingsInformation(this.state.savings)
    );

    return (
      <div>
        <h1 id="tableLabel">Savings Information</h1>
        <p>
          This component demonstrates fetching savings information from the test
          provider API.
        </p>
        {contents}
      </div>
    );
  }

  async populateSavingsData() {
    var myHeaders = new Headers();
    myHeaders.append(
      "Authorization",
      "Basic Nm1rcGs1ZWd1Z2UycjFtZWkwOHEwZDV1cjI6MTZzOTllcTMxZW5vNGE4MTc0cjl2cDlvZW1jbXMwMmVnbDNoYTNjazc5NHQ2azBqazNlbQ=="
    );
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
      Merchant: "TIC",
      Lender: "BEN",
      RateType: "VAR",
      RepaymentType: "PI",
      PropertyUsage: "INV",
      CustomerRate: 5,
      LoanTerm: 20,
      BorrowingAmount: 200000,
      RateTerm: null,
    });

    var requestOptions = {
      method: "POST",
      headers: myHeaders,
      body: raw,
      redirect: "follow",
      
    };

    fetch(
      "https://api.stage.tictoc.ai/product/v1.0/calculator/getloancomparison",
      requestOptions
    )
      .then((response) => response.text())
      .then((result) => console.log(result))
      .catch((error) => console.log("error", error));
  }
}
