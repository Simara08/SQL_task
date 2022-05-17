// let a="60";
// let b=10;
// console.log(a+b);
// let c=12;
// console.log(c+b);
// let array= [1,2,3,4,5];
// console.log(array);
// let myarray=0;
//  for (let index = 0; index < array.length; index++) {
//      if (array[index]%2!=0) {
//         //  console.log(array[index]);
//          myarray+=array[index];
//      }
     
//  }
 
//          console.log(myarray);
//task1:
// let a="salam";
// let upper=a.toUpperCase();
// function big(item) {
//     for (let index = 0; index < item.length; index++) {
//     if (item==upper ) {
//         console.log(true);
//     }
//     else{
//         console.log(false);
//     }
//   }
// }

// task2:
// function Sum(a,b) {
//     let c=a+b;
//     if (c===100 && (a==100||b==100)) {
//         console.log(true);
//     }
//     else{
//         console.log(false);
//     }
// }

// function Kredit(money,ay) {
//   let odenish=(money-odenish)/ay;
//         let qalid =money%ay;
//     for (let i = 0; i < ay; i++) {
      
//         console.log('${i}-ci ay odenish+{odenish}');
//     }
//     console.log(index+"-ci ay" + odenish);
// }
// console.log(Kredit(1000,5));

// let array=[{name:"Memmed",degree:89},{name:"Murad",degree:97},{name:"Memmed",degree:71},{name:"Gulay",degree:63}]
// function Check(degree) {

//     for (const iterator of array) {
//         if (degree>=95 && degree<=100 ) {
//             if (iterator.degree>=95 && iterator.degree<=100) {
//         console.log("yuksek sheref");
//         console.log(iterator.name);
//         return iterator.name;
//             }
//         }
//     else if(degree<95 && degree>=85 ){
//         if (iterator.degree>=85 && iterator.degree<95) {
//         console.log(" sheref");
//         console.log(iterator.name);
//         return iterator.name;
//         }
//     }
//     else if(degree<85 && degree>=65){
//         if ( iterator.degree>=65 && iterator.degree<85) {
//          console.log(" adi");
//         console.log(iterator.name);
//         return iterator.name;
//         }
//     }
//     else {
//         if ( iterator.degree<65){
//         console.log(" Kesilmish");
//         console.log(iterator.name);
//         return iterator.name;
//         }
//     }
//   }
// }
// Check(90);

function Myfunck(array,funck) {
    let res =[];
    for (let i = 0; i < array.length; i++) {
        res.push(funck(array[i]))
    }
    return res;
}

    function Call(n) {
    return n*5
    }
let arr=[1,3,5,7];

console.log(Myfunck(arr,Call));

