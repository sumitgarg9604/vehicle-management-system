//viewListingForm.jsx
// Returns Form consisting of Buttons to view and create vehicles filtering based on vehicle type
// using <selectAndCreate.jsx>

class ViewListingForm extends React.Component {

    render() {
        const divStyle = {
            padding: '30px'
        };

        //passing data from class SelectVehicle using props
        //selectedVehicleType is the dropdown selection element
        //viewLink the customized link generated based on selection
        //creatingLink is the customized link generated for creating a new vehile based on selection
        var selectedVehicleType = this.props.selectedVehicle

        // it will generate "/Home/ViewCarListings" or "/Home/ViewBoatListings"
        var viewLink = "/Home/" + "View" + selectedVehicleType + "Listings/"

        // it will generate "/Home/CreateCar/" or "/Home/CreateBoat/"
        var createLink = "/Home/" + "Create" + selectedVehicleType + "/"


        //method that nullifies viewlink and createlink values if no selection to avoid errors
        const renderStatus = () => {

            let component = ''
            switch (selectedVehicleType) {
                case 'No value':
                    viewLink = "/"
                    createLink = "/"

                    break;

                default:
                    break;
            }

            return component;
        }

        //returns two buttons 
        // View Listings - to view existing added listings based on selection of vehicle from dropdown
        //Create Vehicle - to create a new vehicle listing based on selection of vehile from dropdown
        return (

            <div>
                <form>
                    {renderStatus()}
                    <div className="d-flex justify-content-center">
                        <a id="ViewLink" href={viewLink} className='btn btn-primary' >View Listings</a>



                        <div className="col-1"></div>

                        <a id="CreateLink" href={createLink} className='btn btn-primary'>Create Vehicle</a>
                    </div>

                </form>
            </div >

        );
    }
}
