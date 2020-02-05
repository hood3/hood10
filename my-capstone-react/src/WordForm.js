import React, {Component} from 'react';

class WordForm extends Component {
    constructor(props) {
      super(props);
      this.state = {value: ''};
  
      this.handleChange = this.handleChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);
    }
  
    handleChange(event) {
      this.setState({value: event.target.value});
    }
  
    handleSubmit(event) {
      var word = this.state.value;      
      alert(word);
      //alert('A word was submitted: ' + this.state.value);     this was for testing purpose only
      event.preventDefault();
      
    }
  
    render() {
      return (
        <form onSubmit={this.handleSubmit} class="form">
          <label>
            Word:
            <input type="text" value={this.state.value} onChange={this.handleChange} />
          </label>
          <input type="submit" value="Submit to library" class="btnone" />
        </form>
      );
    }
  }  

 export default WordForm;