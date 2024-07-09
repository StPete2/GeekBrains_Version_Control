const user = {
    name: "Aleksey",
    address: {
        street: "Pl. Chernyshevskogo",
        city: "St. Petersburg"
    },
    contacts: {
        email: "stpete@mail.ru",
        telephone: "+79117717191"
    }
};

const email = user?.contacts?.email ?? "email not mentioned";
console.log(email);
const district = user?.address?.district ?? "district not mentioned";
console.log(district);