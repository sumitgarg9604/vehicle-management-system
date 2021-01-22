//addCar - to add a Car Listing to database using API POST


class Addcar extends React.Component {
    constructor(props) {
        super(props)
        this.state = {

            //Initializing arrays for drop down boxes data to save multiple values
            vehicleTypeData: [],
            bodyTypeData: [],
            adTypeData: [],

            //Initializing state variables for fields related to car Listing
            make: '',
            model: '',
            vehicleType: '',
            engine: '',
            doors: '',
            adType: '',
            wheels: '',
            bodyType: '',

            //to save error state in case valisation fails
            errors: {}
        }
    }


    //method to handle validations and error messages
    handleValidation() {
        let { make, model, vehicleType, engine, doors, adType, wheels, bodyType } = this.state;
        let errors = {};
        let formIsValid = true;

        //if make field is empty
        if (!(make).trim()) {
            formIsValid = false;
            errors["make"] = "Please enter Make of Vehicle";
        }

        //if model field is empty
        if (!(model).trim()) {
            formIsValid = false;
            errors["model"] = "Please enter Model of Vehicle";
        }

        //if dropdown VehicleType is unselected
        if (!(vehicleType)) {
            formIsValid = false;
            errors["vehicleType"] = "Please select an option";
        }

        //if engine field is empty
        if (!(engine).trim()) {
            formIsValid = false;
            errors["engine"] = "Please enter Engine Information";
        }

        //if doors field is put in negative number
        if (doors < 0) {
            formIsValid = false;
            errors["doors"] = "Number of Wheels cannot be in negative";
        }

        //if doors field is entered as zero
        if (doors == 0) {
            formIsValid = false;
            errors["doors"] = "Number of Wheels cannot be zero";
        }

        //if doors field is left empty
        if (!(doors).trim()) {
            formIsValid = false;
            errors["doors"] = "Please enter number of wheels";
        }

        //if wheels field is put in negative number
        if (wheels < 3) {
            formIsValid = false;
            errors["wheels"] = "Minimum number of wheels should be 3 for a car";
        }

        //if doors field is put as zero
        if (wheels == 0) {
            formIsValid = false;
            errors["wheels"] = "Number of Wheels cannot be zero";
        }

        //if doors field is left empty
        if (!(wheels).trim()) {
            formIsValid = false;
            errors["wheels"] = "Please enter number of wheels";
        }


        //if dropdown bodyType is unselected
        if (!(bodyType)) {
            formIsValid = false;
            errors["bodyType"] = "Please select an option";
        }

        //if dropdown adType is unselected
        if (!(adType)) {
            formIsValid = false;
            errors["adType"] = "Please select an option";
        }


        this.setState({ errors: errors });
        return formIsValid;
    }

    //using Axios GET method to populate vehicleType Dropdown
    async getVehicles() {
        const response = await axios.get("https://localhost:44375/api/VehicleTypes")
        const data = response.data
        const vehicles = data.map(d => ({
            'vehicleType': d.vehicleType
        }))
        this.setState({ vehicleTypeData: vehicles })
    }

    //using Axios GET method to populate adType Dropdown
    async getAdTypes() {
        const response = await axios.get("https://localhost:44375/api/AdTypes")
        const data = response.data
        const ads = data.map(d => ({
            'adType': d.adType
        }))
        this.setState({ adTypeData: ads })
    }

    //using Axios GET method to populate BodyType Dropdown
    async getBodyTypes() {
        const response = await axios.get("https://localhost:44375/api/BodyTypes")
        const data = response.data
        const bodyTypes = data.map(d => ({
            'bodyType': d.bodyType
        }))
        this.setState({ bodyTypeData: bodyTypes })
    }


    //calling methods upon page load
    // it will populate all drop down boxes at the first instance of page laod
    componentDidMount() {
        this.getVehicles();
        this.getAdTypes();
        this.getBodyTypes();
    }

    //method to handle change activity in fields and assigned input value
    handleChange = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    //method to handle change of selection in dropdown vehicleType
    handleDropDownChangeVehicle = (e) => {
        this.setState({ vehicleType: e.target.value })
    }

    //method to handle change of selection in dropdown adType
    handleDropDownChangeAd = (e) => {
        this.setState({ adType: e.target.value })
    }

    //method to handle change of selection in dropdown bodyType
    handleDropDownChangeBody = (e) => {
        this.setState({ bodyType: e.target.value })
    }

    //method to clear all values upon form successful submission
    clearValues() {
            this.state.make = '',
            this.state.model = "",
            this.state.vehicleType = '',
            this.state.engine = '',
            this.state.doors = '',
            this.state.adType = '',
            this.state.wheels = '',
            this.state.bodyType = ''
    }

    //method to handle form when submitted
    submitHandler = e => {
        e.preventDefault()

        //hadling form validation
        //if true - successful message and post the details
        if (this.handleValidation()) {
            Swal.fire(
                'Vehicle Added Successfully',
                '',
                'success'
            )
            axios.post('https://localhost:44375/api/Cars',
                {
                    make: this.state.make,
                    model: this.state.model,
                    vehicleType: this.state.vehicleType,
                    engine: this.state.engine,
                    doors: parseInt(this.state.doors),
                    adType: this.state.adType,
                    wheels: parseInt(this.state.wheels),
                    bodyType: this.state.bodyType
                }
            ).then(response => { console.log(response) })
                .catch(error => { console.log(error) })
            this.clearValues();
        }
    }

    render() {

        const divStyle = {
            padding: '30px'
        };


        const { make, model, vehicleType, engine, doors, adType, wheels, bodyType } = this.state
        return (

            <div>


                <h2>Add a Car to Mini CarSales </h2>
                <div className="container-fluid " style={divStyle} >
                    <form onSubmit={this.submitHandler}>
                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Make</label>
                            </div>
                            <div className="col-3">
                                <input className="form-control" type="text" name="make" onChange={this.handleChange} value={make} placeholder="Enter make" />
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["make"]}</span>
                            </div>

                        </div>


                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Model</label>
                            </div>
                            <div className="col-3">
                                <input className="form-control " type="text" name="model" onChange={this.handleChange} value={model} placeholder="Enter model" />
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["model"]}</span>
                            </div>
                        </div>


                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Vehicle Type</label>
                            </div>
                            <div className="col-3">
                                <select className="form-control" name="vehicleType" value={this.state.vehicleType} options={this.state.vehicleTypeData} onChange={this.handleDropDownChangeVehicle.bind(this)}>
                                    <option value="" disabled selected>Select your option</option>
                                    {this.state.vehicleTypeData.map((optionskill) => (
                                        <option key={optionskill.vehicleType} value={optionskill.vehicleType}>{optionskill.vehicleType}</option>
                                    ))}
                                </select>
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["vehicleType"]}</span>
                            </div>
                        </div>





                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Engine</label>
                            </div>
                            <div className="col-3">

                                <input className="form-control" type="text" name="engine" onChange={this.handleChange} value={engine} placeholder="Enter engine" />
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["engine"]}</span>
                            </div>
                        </div>



                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Number of Doors</label>
                            </div>
                            <div className="col-3">

                                <input className="form-control" type="number" name="doors" onChange={this.handleChange} value={doors} placeholder="Enter doors" />
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["doors"]}</span>

                            </div>
                        </div>

                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Adv. Posted by</label>
                            </div>
                            <div className="col-3">

                                <select className="form-control" name="adType" value={this.state.adType} options={this.state.adTypeData} onChange={this.handleDropDownChangeAd.bind(this)}>
                                    <option value="" disabled selected>Select your option</option>
                                    {this.state.adTypeData.map((options) => (
                                        <option key={options.adType} value={options.adType}>{options.adType}</option>
                                    ))}
                                </select>
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["adType"]}</span>
                            </div>
                        </div>


                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Number of Wheels</label>
                            </div>
                            <div className="col-3">

                                <input className="form-control" type="number" name="wheels" onChange={this.handleChange} value={wheels} placeholder="Enter wheels" />
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["wheels"]}</span>
                            </div>
                        </div>

                        <div className="form-group row">
                            <div className="col-2">
                                <label className="text-info">Type of Body</label>
                            </div>
                            <div className="col-3">

                                <select className="form-control" name="bodyType" value={this.state.bodyType} options={this.state.bodyTypeData} onChange={this.handleDropDownChangeBody.bind(this)}>
                                    <option value="" disabled selected>Select your option</option>
                                    {this.state.bodyTypeData.map((options) => (
                                        <option key={options.bodyType} value={options.bodyType}>{options.bodyType}</option>
                                    ))}
                                </select>
                            </div>
                            <div className="col-3">
                                <span className="text-danger">{this.state.errors["bodyType"]}</span>

                            </div>
                        </div>



                        <div className="form-group row">
                            <div className="col-2"></div>
                            <div className="col-1">
                                <button className="form-control" type="submit" className="btn btn-primary">Submit</button>
                            </div>

                            <div className="col-2">
                                <a href="/" className="form-control" type="submit" className="btn btn-primary">Home Page</a>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        );
    }

}


ReactDOM.render(<Addcar />, document.getElementById('content'));