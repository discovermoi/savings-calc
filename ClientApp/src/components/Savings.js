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
    <tbody>
       <tr>
          <td>{savings.borrowingAmount}</td>
       </tr>
    </tbody>
  </table>);
  }

  render() {
    console.log(this.state);
    let contents = this.state.loading ? (
      <p>
        <em>F Loading...</em>
      </p>
    ) : (
      Savings.renderSavingsInformation(this.state.savings)
    );

    return (
      <div>
        <h1 id="tableLabel">Savings Information</h1>
        {contents}
      </div>
    );
  }

  async populateSavingsData() {
    const response = await fetch('savings');
    console.log('wtf is response ', response);
    const data = await response.body;
    this.setState({ savings: data, loading: false });
  }

}
