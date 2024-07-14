let fetchData = (url) => {
    return new Promise((resolve, reject) => {
        fetch(url)
            .then((response) => {
                return response.json();
            })
            .then((data) => {
                return resolve(data);
            })
            .catch((error) => {
                reject("Loading error: ", error);
            });
    });
};

fetchData("https://images-api.nasa.gov")
    .then((data) => {
        console.log("Data recieved: ", data);
    })
    .catch((error) => {
        console.log("Error: ", error);
    });
