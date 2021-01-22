// JavaScript -React
// Returns Drop Down box to select Type of Vehicle such as Car, Boat from API
// Use of Axios to get data from API

class SelectVehicle extends React.Component {
    constructor(props) {
        super(props);
        this.state = {

            // Initializing array to store multiple values
            vehicleTypeData: [],

            //Initializing inital value to selected dropdown
            'vehicleType': 'No value'
        }
    };

    // method to get data from API
    async getVehicles() {

        //GET method to get data from API
        const response = await axios.get("https://localhost:44375/api/VehicleTypes")
        const data = response.data

        //mapping the data
        const vehicles = data.map(d => ({
            'vehicleType': d.vehicleType

        }))

        //assigning multiple values to array 
        this.setState({ vehicleTypeData: vehicles })
    }

    // calls the method getVehicles() when the page is loaded
    componentDidMount() {
        this.getVehicles()
    }

    //method to handle event when state of dropdown is changed
    //assigning the selected value from No Value to new value
    handleChange(e) {
        this.setState({ vehicleType: e.target.value })
    }

    //method to handle form submit button
    handleSubmit = (e) => {
        e.preventDefault();
    }


    //Return - DropDown that consists of values from API for type of vehicle
    //Uses another react component <ViewListingForm.jsx> for other required components
    render() {

        // react constant to style an element 
        const divStyle = {
            padding: '35px'
        };
        return (

            <div className="container border" style={divStyle}>
                <form className="form-group" onSubmit={this.handleSubmit}>

                    <div className="row">
                        <div className="col-3"></div>

                        <div className="col-3">
                            <label className="text-info">Type of Vehicle</label>
                        </div>


                        <div className="col-3">

                            <select className='form-control' options={this.state.vehicleTypeData} onChange={this.handleChange.bind(this)} >

                                <option value="" disabled selected>Select your option</option>
                                {this.state.vehicleTypeData.map((optionskill) => (
                                    <option key={optionskill.vehicleType} value={optionskill.vehicleType}>  {optionskill.vehicleType}</option>
                                ))}
                            </select>
                        </div>
                    </div>


                    <div className="d-flex justify-content-center">
                        <p>Select type of Vehicle and Proceed to View or Create New Listing <strong></strong></p>
                    </div>


                    <ViewListingForm selectedVehicle={this.state.vehicleType} />


                </form>


            </div>
        );
    }


}

// rendering this javascript in view Index.cshtml
ReactDOM.render(<SelectVehicle />, document.getElementById('content'))

