//ViewVehicles.jsx
//Used in view ViewCarListings.cshtml, ViewBoatListings.cshtml
//Contains components
    //AdTypeDropDown
    //CarList
//Returns Vehicle Data based on selection of vehicle
//Filters based on adposted by


// AdTypeDropDown - returns HTML dropdownn with values from API of all the types of ads being posted
//Uses component CarList to View Car Vehicle Type

class AdTypeDropDown extends React.Component {
    constructor(props) {
        super(props);
        this.state = {

            // Initializing array to store multiple values
            adTypeData: [],

            //Initializing inital value to selected dropdown
            'adType': ''

        }
    }

    // method to get data from API
    async getAdData() {

        //GET method to get data from API
        const response = await axios.get("https://localhost:44375/api/AdTypes")
        const data = response.data

        //mapping the data
        const ads = data.map(d => ({
            'adType': d.adType

        }))

        //assigning multiple values to array 
        this.setState({ adTypeData: ads })
    }

    // calls the method getAdData() when the page is loaded
    componentDidMount() {
        this.getAdData()
    }

    //method to handle event when state of dropdown is changed
    //assigning the selected value from No Value to new value
    handleChange(e) {
        this.setState({ adType: e.target.value })
    }

    //method to handle form submit button
    handleSubmit = (e) => {
        e.preventDefault();
    }

    //Return - DropDown that consists of values from API for type of ads
    //Uses another react component <CarList.jsx> for other required components
    render() {

        return (
            <div class="container">
                <h2>Car Listings at Mini Car Sales</h2>

                <label class="text-info">Filter </label>

                <form className="form-group" onSubmit={this.handleSubmit}>

                    <select className="form-control" options={this.state.adTypeData} onChange={this.handleChange.bind(this)}>
                        <option value="" disabled selected>Select your option</option>
                        {this.state.adTypeData.map((optionskill) => (
                            <option key={optionskill.adType} value={optionskill.adType}>{optionskill.adType}</option>
                        ))}
                    </select>

                    <CarList filterBy={this.state.adType} />

                </form>


            </div>
        );
    }
}

// CarList - to return a data table based on selection of vehicle and filter based on ads
class CarList extends React.Component {

    constructor() {
        super();
        this.state = {

            // Initializing array to store multiple values
            CarData: [],

             //Initializing inital value to selected filter value
            filterAd: ''
        }
    }

    //method to get data from API
    //maps and assigns value to array initialized above
    //props used to get selected filter value
    //assigning filter value to var filterAd
    componentDidMount() {
        axios.get("https://localhost:44375/api/Cars").then
            (response => {
                this.setState({
                    CarData: response.data,

                })
            }).then(res => { this.setState({ filterAd: this.props.filterBy }) })
    }


    //return data in a table format
    //and filter method is used to filter data based on adType - filterAd
    render() {

        //assigns selected filter value to variable filterAd
        var filterAd = this.props.filterBy

        //applying filter method to filter the data based on filterAd
        var toFilterCarData = this.state.CarData.filter(function (cars) {
            return cars.adType === filterAd;
        });

        //returns table 
        return (

            <section>
                <br />
                <div >

                    <table className="table table-dark">
                        <thead><tr>
                            <th scope="col">Make</th>
                            <th scope="col">Model</th>
                            <th scope="col">Engine</th>
                            <th scope="col">Vehicle Type</th>
                            <th scope="col">Adv. Posted By</th>
                            <th scope="col">Number of wheels</th>
                            <th scope="col">Number of Doors</th>
                            <th scope="col">Type of Body</th>
                        </tr></thead>
                        <tbody>
                            {
                                toFilterCarData.map((p, index) => {
                                    return <tr key={index} >
                                        <td> {p.make}</td>
                                        <td>{p.model}</td>
                                        <td>{p.engine}</td>
                                        <td>{p.vehicleType}</td>
                                        <td>{p.adType}</td>
                                        <td>{p.wheels}</td>
                                        <td>{p.doors}</td>
                                        <td>{p.bodyType}</td>
                                    </tr>;
                                })
                            }
                        </tbody>
                    </table>
                </div>

                <a href="/" className="form-control" type="submit" className="btn btn-primary">Home Page</a>
            </section>
        );
    }
}


//Rendering the class AdTypeDropDown in ViewCarListings.cshtml
ReactDOM.render(<AdTypeDropDown />, document.getElementById('content'));