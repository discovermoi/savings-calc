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
    return (
    <table className="table table-striped" aria-labelledby="tableLabel">
      <h1>This will be the Savings Amount</h1>
    <tbody>
      {savings.map(savingsdata =>
       <tr>
          <td>{savingsdata.borrowingAmount}</td>
       </tr>
      )}
    </tbody>
  </table>);
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
    const response = await fetch('savingscalculator');
    // console.log('wtf is response ', response);
    // const data = await response.json();
    // this.setState({ savings: data, loading: false });
  }

}
